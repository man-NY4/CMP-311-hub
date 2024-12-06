const express = require('express');
const app = express();
app.use(express.json());
const mysql = require('mysql2');

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
        facultyLastName = req.body.facultyLast
        facultyFirstName = req.body.facultyFirst
        faculty_Email = req.body.facultyEmail

        if (err) throw err;
        console.log("Connected!");

        if (!facultyLastName || facultyLastName.length < 3 || !facultyFirstName || facultyFirstName.length < 3 || !faculty_Email) 
            return res.status(400).send('Minimum 3 characters');

        var sql = "INSERT INTO faculty (facultyLast, facultyFirst, facultyEmail) VALUES (?, ?, ?)";
        con.query(sql,[facultyLastName, facultyFirstName, faculty_Email], function (err, result) {
          if (err) throw err;
          else{
            console.log("1 record inserted");
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
        facultyLastName = req.body.facultyLast
        facultyFirstName = req.body.facultyFirst
        faculty_Email = req.body.facultyEmail
        facultyId = parseInt(req.params.id)

        if (err) throw err;
        console.log("Connected!");

        if (!facultyLastName || facultyLastName.length < 3 || !facultyFirstName || facultyFirstName.length < 3 || !faculty_Email) 
            return res.status(400).send('Minimum 3 characters');
        
        var sql = "UPDATE faculty SET facultyLast = ?, facultyFirst = ?, facultyEmail = ? WHERE id =" + parseInt(req.params.id);
        con.query(sql, [facultyLastName, facultyFirstName, faculty_Email], function (err, result) {
          if (err) throw err;

          if(result.affectedRows === 0)
            res.status(404).send("Id not found")

          else{
            console.log("1 record updated");
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
        facultyId = parseInt(req.params.id)

        if (err) throw err;

        if (isNaN(facultyId) || facultyId <= 0)
            return res.status(404).send('Id not found');

        var sql = "DELETE FROM faculty WHERE id =" + parseInt(req.params.id);
        con.query(sql, function (err, result) {
          if (err) throw err;

          if(result.affectedRows === 0)
            res.status(404).send("Id not found")
        
          else{
            console.log("Number of records deleted: " + result.affectedRows);
            res.send(result)
          }
        });
    });

});

const port = process.env.PORT || 4000;
app.listen(port, () => {
    console.log(`Listening on port ${port}...`)
});