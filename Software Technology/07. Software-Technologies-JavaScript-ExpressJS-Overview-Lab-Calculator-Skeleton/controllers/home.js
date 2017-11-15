const Calculator=require('../models/Calculator');
module.exports = {
    indexGet: (req, res) => {
        res.render('home/index');
    },
    indexPost:(req,res)=>{
        let calculatorBody=req.body;
        let calculatorparams=calculatorBody['calculator'];

        let calculator=new Calculator();
        calculator.leftOperand=Number(calculatorparams.leftOperand);
        calculator.operator=calculatorparams.operator;
        calculator.rightOperand=Number(calculatorparams.rightOperand);

        let result=calculator.calculateResult();
        res.render('home/index',{'calculator':calculator,'result':result});
    }
};