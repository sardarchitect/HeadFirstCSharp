namespace BeehiveManagementSystem;
internal abstract class Bee : IWorker
{
    public string Job { get; private set; }
    public abstract decimal CostPerShift { get; }
    public Bee(string job)
    {
        Job = job;
    }
    public virtual bool WorkTheNextShift()
    {
        if (HoneyVault.ConsumeHoney(CostPerShift)) return true;
        else return false;
    }
}