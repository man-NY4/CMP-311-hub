const mysql = require('mysql2');

var con = mysql.createConnection({
  host: "localhost",
  user: "emmanuel_medina",
  password: "Frog2570739707!",
  database: "mydb"
});

con.connect(function(err) {
    if (err) throw err;
    var sql = "DROP TABLE students";
    con.query(sql, function (err, result) {
      if (err) throw err;
      console.log("Table deleted");
    });
});