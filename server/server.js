const express = require("express");
const cors = require("cors");

const app = express();
const mysql = require("mysql");
const dbConfig = require("./db.js");

const con = mysql.createConnection({
    host: dbConfig.HOST,
    user: dbConfig.USER,
    password: dbConfig.PASSWORD,
    database: dbConfig.DB
  });


var corsOptions = {
  origin: "http://localhost:8081"
};

app.use(cors(corsOptions));

// parse requests of content-type - application/json
app.use(express.json());

// parse requests of content-type - application/x-www-form-urlencoded
app.use(express.urlencoded({ extended: true }));

// simple route
app.get("/api/questions", (req, res) => {
    con.connect(function(err) {
        if (err) throw err;
        con.query("SELECT * FROM questions", function (err, result, fields) {
          if (err) throw err;
          res.json(result)
        });
      });
}); 


// set port, listen for requests
const PORT = process.env.PORT || 8080;
app.listen(PORT, () => {
  console.log(`Server is running on port ${PORT}.`);
});