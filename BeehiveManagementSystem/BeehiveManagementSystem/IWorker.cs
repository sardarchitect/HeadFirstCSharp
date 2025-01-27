namespace BeehiveManagementSystem;
internal interface IWorker
{
    public abstract string Job { get; }
    public abstract bool WorkTheNextShift();
}
