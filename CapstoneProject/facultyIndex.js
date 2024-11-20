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
        con.query("SELECT * FROM faculty", function (err, result) {
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
        con.query("SELECT * FROM faculty WHERE id = " + parseInt(req.params.id), 
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
        facultyLast = req.body.facultyLast
        facultyFirst = req.body.facultyFirst
        facultyEmail = req.body.facultyEmail
        if (err) throw err;
        console.log("Connected!");
        var sql = "INSERT INTO faculty (facultyLast, facultyFirst, facultyEmail) VALUES ('"+ facultyLast + "', '"+ facultyFirst +"', '"+ facultyEmail +"') ";
        con.query(sql, function (err, result) {
          if (err) throw err;
          else{
            console.log("1 record inserted");
            if (!req.body.facultyLast || req.body.facultyLast.length < 3 || !req.body.facultyFirst || req.body.facultyFirst.length < 3) 
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
        facultyLast = req.body.facultyLast
        facultyFirst = req.body.facultyFirst
        facultyEmail = req.body.facultyEmail
        if (err) throw err;
        console.log("Connected!");
        var sql = "UPDATE faculty SET facultyLast = ?, facultyFirst = ?, facultyEmail = ? WHERE id =" + parseInt(req.params.id);
        con.query(sql, [facultyLast, facultyFirst, facultyEmail], function (err, result) {
          if (err) throw err;
          else{
            console.log("1 record updated");
            if (!req.body.facultyLast || req.body.facultyLast.length < 3 || !req.body.facultyFirst || req.body.facultyFirst.length < 3) 
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
        var sql = "DELETE FROM faculty WHERE id =" + parseInt(req.params.id);
        con.query(sql, function (err, result) {
          if (err) throw err;
          console.log("Number of records deleted: " + result.affectedRows);
          res.send(result)
        });
    });

});

const port = process.env.PORT || 3001;
app.listen(port, () => {
    console.log(`Listening on port ${port}...`)
});