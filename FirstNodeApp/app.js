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
const emitter = new EventEmitter();

emitter.on('messageLogged', function() {
    console.log('Listener called');
});

emitter.emit('messageLogged');
*/