
namespace MathGame.operations;

public class Division : IOperation
{

    private int _result;
    private int _firstNumber;
    private int _secondNumber;
    public Division(){
        Random randomGenerator = new();
         _firstNumber = randomGenerator.Next(0, 100);
         _secondNumber = randomGenerator.Next(0, 100);
        while((_firstNumber % _secondNumber) != 0){
            _firstNumber = randomGenerator.Next(0, 100);
            _secondNumber = randomGenerator.Next(0, 100);
        }
        _result = _firstNumber / _secondNumber;
    }

    public int GetResult()
    {
        return _result;
    }

    public List<int> GetOperationNumbers()
    {
        List<int> operands = new();
        operands.Add(_firstNumber);
        operands.Add(_secondNumber);
        return operands;
    }


    public string ShowOperation(){
        return $"{_firstNumber} / {_secondNumber}";
    }
}
