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

app.get('/api/customers', (req, res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "emmanuel_medina",
        password: "Frog2570739707!",
        database: "mydb"
    });

    con.connect(function(err) {
        if (err) throw err;
        con.query("SELECT * FROM customers", function (err, result) {
          if (err) throw err;
          else{
            console.log(result);
            res.send(result);
          }
        });
    });
});

app.get('/api/customers/:id', (req, res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "emmanuel_medina",
        password: "Frog2570739707!",
        database: "mydb"
    });

    con.connect(function(err) {
        if (err) throw err;
        con.query("SELECT * FROM customers WHERE id = " + parseInt(req.params.id), 
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

app.post('/api/customers',(req, res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "emmanuel_medina",
        password: "Frog2570739707!",
        database: "mydb"
    });

    
    con.connect(function(err) {
        customerName = req.body.name
        customerAddress = req.body.address
        if (err) throw err;
        console.log("Connected!");
        var sql = "INSERT INTO customers (name, address) VALUES ('"+ customerName + "', '"+customerAddress+"') ";
        con.query(sql, function (err, result) {
          if (err) throw err;
          else{
            console.log("1 record inserted");
            if (!req.body.name || req.body.name.length < 3) return res.status(400).send('Minimum 3 characters');
                res.send(result)
          }
        });
    });

});

const port = process.env.PORT || 3000;
app.listen(port, () => {
    console.log(`Listening on port ${port}...`)
});