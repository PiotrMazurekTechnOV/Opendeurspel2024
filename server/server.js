const express = require("express");
const cors = require("cors");
require('dotenv').config()

const app = express();
const mysql = require('mysql2/promise');

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

//INSERT sql querry test
app.post("/api/Users/add", async (req, res) => {
  try {
    const con = await connect();

    
    const { age, tel, email } = req.body;

    
    const [results, fields] = await con.execute(
      "INSERT INTO users (age, tel, email) VALUES (?, ?, ?)",
      [age, tel, email]
    );

    res.json({ message: "User added successfully", userId: results.insertId });
  } catch (err) {
    res.json({ error: err.message });
  }
});


// simple route
app.get("/api/questions", async (req, res) => {
  try {
    const con = await connect();
    const [results, fields] = await con.execute("SELECT * FROM questions")
    res.json(results)
  }
  catch (err){
    res.json(err)
  }
  
}); 

app.get("/api/test", (req, res) => {
  console.log("test");
  res.json("test");
}); 

// set port, listen for requests
const PORT = process.env.PORT || 8080;
app.listen(PORT, () => {
  console.log(`Server is running on port ${PORT}.`);
});