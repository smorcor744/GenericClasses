namespace GenericClasses;

public class FinishEvent
{
    public Action FinishAction;

    public FinishEvent()
    {
        FinishAction = () => { };
    }
}