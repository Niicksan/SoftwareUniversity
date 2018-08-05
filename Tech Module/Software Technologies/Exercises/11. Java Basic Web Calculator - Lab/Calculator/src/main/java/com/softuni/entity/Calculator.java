package com.softuni.entity;

public class Calculator {
    private double leftOperand;
    private double rightOperand;
    private String operator;

    public Calculator(double leftOperand, double rightOperand, String operator) {
        this.leftOperand = leftOperand;
        this.rightOperand = rightOperand;
        this.operator = operator;
    }

    public double getleftOperand() {
        return leftOperand;
    }

    public void setleftOperand(double leftOperand) {
        this.leftOperand = leftOperand;
    }

    public double getRightOperand() {
        return rightOperand;
    }

    public void setRightOperand(double rightOperand) {
        this.rightOperand = rightOperand;
    }

    public String getOperator() {
        return operator;
    }

    public void setOperator(String operator) {
        this.operator = operator;
    }

    public double calculateResult() {
        double result = 0;

        switch (this.operator) {
            case "+":
                result = this.getleftOperand() + this.getRightOperand();
                break;
            case "-":
                result = this.getleftOperand() - this.getRightOperand();
                break;
            case "*":
                result = this.getleftOperand() * this.getRightOperand();
                break;
            case "/":
                result = this.getleftOperand() / this.getRightOperand();
                break;
            case "%":
                result = this.getleftOperand() % this.getRightOperand();
                break;
            case "^":
                result = Math.pow(this.getleftOperand(), this.getRightOperand());
                break;
            case "√":
                result = this.getleftOperand() + Math.sqrt(this.getRightOperand());
                break;
        }
        return result;
    }
}
