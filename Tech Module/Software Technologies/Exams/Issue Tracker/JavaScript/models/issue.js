const Sequelize = require('sequelize');

module.exports = function (sequelize) {
    const Issue = sequelize.define("Issue",{
        title: {
            type: Sequelize.TEXT,
            required: true,
            allowNull: false
        },
        content: {
            type: Sequelize.TEXT,
            required: true,
            allowNull: false
        },
        priority: {
            type: Sequelize.INTEGER,
            required: true,
            allowNull: false
        }
    }, {
        timestamps: false
    })

    return Issue;
};