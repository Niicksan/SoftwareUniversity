const Project = require('../models').Project;

module.exports = {
    // Index
    index: (req, res) => {
        Project.findAll().then(projects => {
            res.render("project/index", {projects: projects});
        })
    },

    // Create
    createGet: (req, res) => {
        res.render("project/create");
    },
    createPost: (req, res) => {
        let body = req.body.project;

        // let obj = {
        //     title: body.Title,
        //     description: body.Description,
        //     budget: body.Budget
        // }

        Project.create(body).then(() => {
            res.redirect("/");
        })
    },

    // Edit
    editGet: (req, res) => {
        let id = req.params.id;

        Project.findById(id).then(project => {
            res.render("project/edit", {project: project});
        })
    },
    editPost: (req, res) => {
        let id = req.params.id;
        let body = req.body.project;

        Project.findById(id).then(project => {
            project.title = body.title;
            project.description = body.description;
            project.budget = body.budget;

            project.save().then(() => {
                res.redirect("/");
            })
        })
    },

    // Delete
    deleteGet: (req, res) => {
        let id = req.params.id;

        Project.findById(id).then(project => {
            res.render("project/delete", {project: project});
        })

    },
    deletePost: (req, res) => {
        let id = req.params.id;

        Project.findById(id).then(project => {
            project.destroy().then(() => {
                res.redirect("/");
            })
        })
    }

};