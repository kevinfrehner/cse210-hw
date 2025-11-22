public class Goal
{
    private string _title;
    private string _description;
    private int _points;
    private bool _isComplete;

    public string Title { get { return _title; } }
    public string Description { get { return _description; } }
    public int Points { get { return _points; } }

    public Goal(string title, string description, int points)
    {
        _title = title;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public virtual int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public virtual bool IsComplete()
    {
        return _isComplete;
    }

    public virtual string GetStatus()
    {
        return _isComplete ? "[X]" : "[ ]";
    }
}
