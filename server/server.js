const express = require("express");
const cors = require("cors");
require('dotenv').config()

const app = express();
const mysql = require('mysql2/promise');

let code = 99;

// Create the connection to database
async function  connect()
{
  const con = await mysql.createConnection({
    host: process.env.HOST,
    user: process.env.USER,
    database: process.env.DB,
    password: process.env.PASSWORD
  });
  return con;
}


var corsOptions = {
  origin: "http://localhost:8081"
};

app.use(cors(corsOptions));

// parse requests of content-type - application/json
app.use(express.json());

// parse requests of content-type - application/x-www-form-urlencoded
app.use(express.urlencoded({ extended: true }));

//Users toevoegen
app.post("/api/user/add", async (req, res) => {
  try {
    console.log(req.body);
    const con = await connect();

    
    const { firstName, lastName, age, interest, email, consent } = req.body;
    code += 1;
    const [results, fields] = await con.execute(
      "INSERT INTO users (firstName, lastName, age, interest, email, consent, code) VALUES (?, ?, ?, ?, ?, ?, ?)",
      [firstName, lastName, age, interest, email, consent, code]
    );

    res.json("User added successfully");
  } catch (err) {
    res.json({ error: err.message });
  }
});
//score toevoegen
app.post("/api/score/add", async (req, res) => {
  try {
    const con = await connect();

    const {score,question_id,user_id} = req.body;
    const [results, fields] = await con.execute(
      "INSERT INTO score (score,question_id,user_id ) VALUES (?, ?,?)",
      [score,question_id,user_id]
    );

    res.json("answers added successfully");
  } catch (err) {
    res.json({ error: err.message });
  }
});
//Locatie toevoegen
app.post("/api/location/add", async (req, res) => {
  try {
    
    const con = await connect();

    
    const { name, room} = req.body;
    code += 1;
    const [results, fields] = await con.execute(
      "INSERT INTO locations (name, room) VALUES (?, ?)",
      [name, room]
    );

    res.json("Location added successfully");
  } catch (err) {
    res.json({ error: err.message });
  }
});

//question toevoegen
app.post("/api/questions/add", async (req, res) => {
  try {
    const con = await connect();

    const { text, location_id,  } = req.body;
    const [results, fields] = await con.execute(
      "INSERT INTO users (text, location_id) VALUES (?, ?)",
      [text, location_id]
    );

    res.json("question added successfully");
  } catch (err) {
    res.json({ error: err.message });
  }
});

//Antwoorden toevoegen
app.post("/api/answers/add", async (req, res) => {
  try {
    const con = await connect();

    const {answers, question_id ,correct} = req.body;
    const [results, fields] = await con.execute(
      "INSERT INTO users (answers, question_id ,correct) VALUES (?, ?,?)",
      [text, location_id]
    );

    res.json("answers added successfully");
  } catch (err) {
    res.json({ error: err.message });
  }
});


// Question verkrijgen
app.get("/api/questions", async (req, res) => {
  console.log("test")
  try {
    const con = await connect();
    const [results, fields] = await con.execute("SELECT * FROM questions")
    res.json(results)
  }
  catch (err){
    res.json(err)
  }
  
}); 

//anwser verkrijgen van specifieke vraag
app.get("/api/answers/:questionId", async (req, res) => {
  try {
    const question_id = req.params.questionId;
    const con = await connect();
    const [results, fields] = await con.execute("SELECT * FROM answers WHERE question_id = " + question_id);
    res.json(results)
  }
  catch (err){
    res.json(err)
  }
}); 

//user verkrijgen
app.get("/api/users", async (req, res) => {
  try {
    const con = await connect();
    const [results, fields] = await con.execute("SELECT * FROM users")
    res.json(results)
  }
  catch (err){
    res.json(err)
  }
}); 
//anwser verkrijgen
app.get("/api/answers", async (req, res) => {
  try {
    const con = await connect();
    const [results, fields] = await con.execute("SELECT * FROM answers")
    res.json(results)
  }
  catch (err){
    res.json(err)
  }
}); 
//location toevoegen
app.get("/api/locations", async (req, res) => {
  try {
    const con = await connect();
    const [results, fields] = await con.execute("SELECT * FROM locations")
    res.json(results)
  }
  catch (err){
    res.json(err)
  }
}); 
//score verkrijgen
app.get("/api/score/:id", async (req, res) => {
  try {

    const user_id = req.params.id;
    const con = await connect();
    const [results, fields] = await con.execute("SELECT * FROM score WHERE user_id =" + user_id)

    res.json(results)
  }
  catch (err){
    res.json(err)
  }
}); 
app.get("/api/score", async (req, res) => {
  try {

    
    const con = await connect();
    const [results, fields] = await con.execute("SELECT * FROM score ")

    res.json(results)
  }
  catch (err){
    res.json(err)
  }
}); 

//users verkrijgen op basis van code
app.get("/api/user/:code", async (req, res) => {
  try {
    const con = await connect();
    const code = req.params.code;
    const [results, fields] = await con.execute("SELECT * FROM users WHERE code = ?", [code] );
    
    res.json(results)
  }
  catch (err){
    res.json(err)
  }
  
}); 

//locatie verkijgen op basis van room ID
app.get("/api/location/:roomId", async (req, res) => {
  try {
    const con = await connect();
    const id = req.params.roomId;
    const [results, fields] = await con.execute("SELECT * FROM locations WHERE room = ?", [id] );
    
    res.json(results[0])
  }
  catch (err){
    res.json(err)
  }
  
}); 

//vraag verkrijgen op basis van de location id
app.get("/api/question/:locationId", async (req, res) => {
  try {
    const con = await connect();
    const id = req.params.locationId;
    const [results, fields] = await con.execute("SELECT * FROM locations WHERE id = ?", [id] );
    
    res.json(results[0])
  }
  catch (err){
    res.json(err)
  }
  
}); 


//test get
app.get("/api/test", (req, res) => {
  console.log("test");
  res.json("test");
}); 

// set port, listen for requests
const PORT = process.env.PORT || 80;
app.listen(PORT, () => {
  console.log(`Server is running on port ${PORT}.`);
});