public abstract class MarleyMachineDecorator : IMarleyMachine
{
    private IMarleyMachine marleyMachine;
    public MarleyMachineDecorator(IMarleyMachine marleyMachine)
    {
        this.marleyMachine = marleyMachine;
    }

    public virtual void ShowPrice()
    {
        marleyMachine.ShowPrice();
    }
}