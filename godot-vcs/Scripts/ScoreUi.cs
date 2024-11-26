using Godot;

public partial class ScoreUi : Label
{
	private int score = 0;

    public override void _Ready()
    {
        UpdateScoreDisplay();
    }
    
    public void IncrementScore(int pointValue)
	{
		score += pointValue;
        UpdateScoreDisplay();
	}

	public void UpdateScoreDisplay()
	{
        Text = $"Score: {score}";
    }
}
