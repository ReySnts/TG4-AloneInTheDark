public class HorClamp4 : Clamp
{
    protected override void SetCursor()
    {
        leftCursor = FindObjectOfType<Cursor4>();
        rightCursor = FindObjectOfType<Cursor5>();
    }
}