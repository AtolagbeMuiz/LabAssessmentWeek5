public class StudentB :Marks
{
    private int[] _studentBMarks;
    public StudentB(int[] marks)
    {
        this._studentBMarks = marks;
    }

    public override void getPercentage()
    {
        int sum=0;
        for (int i = 0; i < _studentBMarks.Length; i++)
        {
            sum += _studentBMarks[i];

        }
        var result = sum/_studentBMarks.Length;
        var finalPercentageResult = result;
        System.Console.WriteLine("The percentage of Student B is "+ finalPercentageResult + "%");
    }
}