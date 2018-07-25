const Calculator = require('../models/Calculator');

module.exports = {

    indexGet: (req, res) => {
        res.render('home/index');
    },

    indexPost: (req, res) => {
        let calculatorData = req.body;

        let calculatorParams = calculatorData['calculator'];

        let calculator = new Calculator();
        calculator.leftOperand = Number(calculatorParams.leftOperand);
        calculator.operator = calculatorParams.operator;
        calculator.rightOperand = Number(calculatorParams.rightOperand);

        let result = calculator.calculate();

        res.render('home/index', {'calculator': calculator, 'result': result});
    }
};