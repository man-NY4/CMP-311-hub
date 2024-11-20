const express = require('express');
const app = express();
app.use(express.json());
var mysql = require('mysql2');

app.get('/', (req, res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "emmanuel_medina",
        password: "Frog2570739707!",
        database: "mydb"
    });

    con.connect(function(err) {
        if (err) throw err;
        console.log("Connected to the database");
    });
    res.send('Connected to the database');
});

app.get('/api/capstone', (req, res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "emmanuel_medina",
        password: "Frog2570739707!",
        database: "mydb"
    });

    con.connect(function(err) {
        if (err) throw err;
        con.query("SELECT * FROM students", function (err, result) {
          if (err) throw err;
          else{
            console.log(result);
            res.send(result);
          }
        });
    });
});

app.get('/api/capstone/:id', (req, res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "emmanuel_medina",
        password: "Frog2570739707!",
        database: "mydb"
    });

    con.connect(function(err) {
        if (err) throw err;
        con.query("SELECT * FROM students WHERE id = " + parseInt(req.params.id), 
        function (err, result) {
          if (err) throw err;
          else {
            console.log(result);
            if (result == "") return res.status(404).send('Id not found');
                res.send(result);
          }
        });
    });   
});

app.post('/api/capstone',(req, res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "emmanuel_medina",
        password: "Frog2570739707!",
        database: "mydb"
    });

    
    con.connect(function(err) {
        studentLast = req.body.lastName
        studentFirst = req.body.firstName
        studentEmail = req.body.email
        if (err) throw err;
        console.log("Connected!");
        var sql = "INSERT INTO students (lastName, firstName, email) VALUES ('"+ studentLast + "', '"+ studentFirst +"', '"+ studentEmail +"') ";
        con.query(sql, function (err, result) {
          if (err) throw err;
          else{
            console.log("1 record inserted");
            if (!req.body.lastName || req.body.lastName.length < 3 || !req.body.firstName || req.body.firstName.length < 3) 
                return res.status(400).send('Minimum 3 characters');
                res.send(result)
          }
        });
    });

});

app.put('/api/capstone/:id',(req, res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "emmanuel_medina",
        password: "Frog2570739707!",
        database: "mydb"
    });

    con.connect(function(err) {
        studentLast = req.body.lastName
        studentFirst = req.body.firstName
        studentEmail = req.body.email
        if (err) throw err;
        console.log("Connected!");
        var sql = "UPDATE students SET lastName = ?, firstName = ?, email = ? WHERE id =" + parseInt(req.params.id);
        con.query(sql, [studentLast, studentFirst, studentEmail], function (err, result) {
          if (err) throw err;
          else{
            console.log("1 record updated");
            if (!req.body.lastName || req.body.lastName.length < 3 || !req.body.firstName || req.body.firstName.length < 3) 
                return res.status(400).send('Minimum 3 characters');
                res.send(result)
          }
        });
    });
});


app.delete('/api/capstone/:id',(req, res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "emmanuel_medina",
        password: "Frog2570739707!",
        database: "mydb"
    });

    con.connect(function(err) {
        if (err) throw err;
        var sql = "DELETE FROM students WHERE id =" + parseInt(req.params.id);
        con.query(sql, function (err, result) {
          if (err) throw err;
          console.log("Number of records deleted: " + result.affectedRows);
          res.send(result)
        });
    });

});

const port = process.env.PORT || 3000;
app.listen(port, () => {
    console.log(`Listening on port ${port}...`)
});