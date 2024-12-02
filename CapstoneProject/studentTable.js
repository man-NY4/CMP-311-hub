const mysql = require('mysql2');

var con = mysql.createConnection({
  host: "localhost",
  user: "emmanuel_medina",
  password: "Frog2570739707!",
  database: "mydb"
});

con.connect(function(err) {
    if (err) throw err;
    console.log("Connected!");
    var sql = "CREATE TABLE students (id INT NOT NULL AUTO_INCREMENT PRIMARY KEY, lastName VARCHAR(255), firstName VARCHAR(255), email VARCHAR(255))";
    con.query(sql, function (err, result) {
      if (err) throw err;
      console.log("Table created");
    });
});