var mysql = require('mysql2');

var con = mysql.createConnection({
  host: "localhost",
  user: "emmanuel_medina",
  password: "Frog2570739707!",
  database: "mydb"
});

con.connect(function(err) {
    if (err) throw err;
    var sql = "UPDATE customers SET address = 'test 123' WHERE address = 'test 37'";
    con.query(sql, function (err, result) {
      if (err) throw err;
      console.log(result.affectedRows + " record(s) updated");
    });
});