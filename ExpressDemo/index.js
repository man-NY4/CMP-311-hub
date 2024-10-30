const express = require('express');
const app = express();

app.use(express.json());

const courses = [
    { id: 1, name: 'course 1'},
    { id: 2, name: 'course 2'},
    { id: 3, name: 'course 3'},
]

app.get('/', (req, res) => {
    res.send('Hello World');
});

app.get('/api/courses', (req, res) => {
    res.send(courses);
});

app.get('/api/courses/:id', (req, res) => {
    const course =courses.find(c => c.id === parseInt(req.params.id));
    if (!course) {
        return res.status(404).send('Not found')
    }

    res.send(course);
});

app.post('/api/courses',(req, res) => {
    if (!req.body.name || req.body.name.length < 3) {
        return res.status(400).send('Minimum 3 characters');
    }
    
    const course = {
        id: courses.length + 1,
        name: req.body.name
    };
    courses.push(course);
    res.send(course);
});

app.put('/api/courses/:id',(req, res) => {
    const course =courses.find(c => c.id === parseInt(req.params.id));
    if (!course) {
        return res.status(404).send('Not found');
    }

    if (!req.body.name || req.body.name.length < 3) {
        return res.status(400).send('Minimum 3 characters');
    }

    course.name = req.body.name;
    res.send(course);
});

app.delete('/api/courses/:id',(req, res) => {
    const course =courses.find(c => c.id === parseInt(req.params.id));
    if (!course){
        return res.status(404).send('Not found');
    } 

    const index = courses.indexOf(course);
    courses.splice(index, 1);

    res.send(course);
});

const port = process.env.PORT || 3000;
app.listen(port, () => {
    console.log(`Listening on port ${port}...`)
});