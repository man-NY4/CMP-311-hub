const express = require('express');
const app = express();

app.use(express.json());

const chessPieces = [
    { id: 1, name: ' the 1'},
    { id: 2, name: ' the 2'},
    { id: 3, name: ' the 3'},
]

app.get('/api/chess', (req, res) => {
    res.send(chessPieces);
});

app.get('/api/chess/:id', (req, res) => {
    const chessPiece =chessPieces.find(c => c.id === parseInt(req.params.id));
    if (!chessPiece) {
        return res.status(404).send('Not found')
    }

    res.send(chessPiece);
});

app.post('/api/chess',(req, res) => {
    if (!req.body.name || req.body.name.length < 3) {
        return res.status(400).send('Minimum 3 characters');
    }
    
    const chessPiece = {
        id: chessPieces.length + 1,
        name: req.body.name
    };
    chessPieces.push(chessPiece);
    res.send(chessPiece);
});

app.put('/api/chess/:id',(req, res) => {
    const chessPiece =chessPieces.find(c => c.id === parseInt(req.params.id));
    if (!chessPiece) {
        return res.status(404).send('Not found');
    }

    if (!req.body.name || req.body.name.length < 3) {
        return res.status(400).send('Minimum 3 characters');
    }

    chessPiece.name = req.body.name;
    res.send(chessPiece);
});

app.delete('/api/chess/:id',(req, res) => {
    const chessPiece =chessPieces.find(c => c.id === parseInt(req.params.id));
    if (!chessPiece){
        return res.status(404).send('Not found');
    } 

    const index = chessPieces.indexOf(chessPiece);
    chessPieces.splice(index, 1);

    res.send(chessPiece);
});

const port = process.env.PORT || 3000;
app.listen(port, () => {
    console.log(`Listening on port ${port}...`)
});