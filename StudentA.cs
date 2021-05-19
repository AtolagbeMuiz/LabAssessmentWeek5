public class StudentA :Marks
{
    private int[] _studentAMarks;
    public StudentA(int[] marks)
    {
        this._studentAMarks = marks;
    }
    public override void getPercentage()
    {
        int sum=0;
        for (int i = 0; i < _studentAMarks.Length; i++)
        {
            sum += _studentAMarks[i];

        }
        var result = sum/_studentAMarks.Length;
        var finalPercentageResult = result;
        System.Console.WriteLine("The percentage of Student A is "+ finalPercentageResult +"%");
    }
}