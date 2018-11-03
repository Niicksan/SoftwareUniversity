const Issue = require('../models').Issue;

module.exports = {
    index: (req, res) => {
        Issue.findAll().then(issues => {
            res.render("issue/index", {issues: issues});
        })
    },
	
    createGet: (req, res) => {
        res.render("issue/create");
    },
	
    createPost: (req, res) => {
        let body = req.body.issue;

        Issue.create(body).then(() => {
            res.redirect("/");
        })
    },
	
    editGet: (req, res) => {
        let id = req.params.id;

        Issue.findById(id).then(issue => {
            res.render("issue/edit", {issue: issue});
        })
    },

    editPost: (req, res) => {
        let id = req.params.id;
        let body = req.body.issue;

        Issue.findById(id).then(issue => {
            issue.title = body.title;
            issue.content = body.content;
            issue.priority = body.priority;

            issue.save().then(() => {
                res.redirect("/");
            })
        })
    },

    deleteGet: (req, res) => {
        let id = req.params.id;

        Issue.findById(id).then(issue => {
            res.render("issue/delete", {issue: issue});
        })
    },
	
    deletePost: (req, res) => {
        let id = req.params.id;

        Issue.findById(id).then(issue => {
            issue.destroy().then(() => {
                res.redirect("/");
            })
        })
    }
};