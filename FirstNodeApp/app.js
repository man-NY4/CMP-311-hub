/*
function sayHello(name) {
    console.log("Hello " + name);
}

sayHello("Gamer");
*/

/*
const log = require('./logger')

log('message')
*/

/*
const path = require('path');

var pathObj = path.parse(__filename);
console.log(pathObj);
*/

/*
const os = require('os');

var totalMem = os.totalmem();
var freeMem = os.freemem;


console.log(`Total Memory: ${totalMem}`);
console.log(`Free Memory: ${freeMem}`);
*/

/*
const fs = require('fs');

//const files = fs.readdirSync('./')
//console.log(files);

fs.readdir('./', function(err, files) {
    if (err) console.log('Error', err);
    else console.log('Result', files)
});
*/

/*
const EventEmitter = require('events');


const Logger = require('./logger');
const logger = new Logger();

logger.on('messageLogged', (arg) => {
    console.log('Listener called', arg);
});

logger.log('message');
*/

const http = require('http');

const server = http.createServer((req, res) => {
    if (req.url === '/') {
        res.write('Hello World');
        res.end();
    }

    if (req.url === '/api/courses') {
        res.write(JSON.stringify([1, 2, 3]));
        res.end();
    }

});



server.listen(3000);
console.log('listening on port 3000...')