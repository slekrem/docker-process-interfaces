namespace IDockerMachineProcess
{
    using Models;
    using Results;

    public interface IDockerMachineProcesse
    {
        IDockerMachineProcesseResult Active(IDockerMachineProcesseModel dockerMachineProcesseModel);

        IDockerMachineProcesseResult Config(IDockerMachineProcesseModel dockerMachineProcesseModel);

        IDockerMachineProcesseResult Create(IDockerMachineProcesseModel dockerMachineProcesseModel);

        IDockerMachineProcesseResult Env(IDockerMachineProcesseModel dockerMachineProcesseModel);

        IDockerMachineProcesseResult Inspect(IDockerMachineProcesseModel dockerMachineProcesseModel);

        IDockerMachineProcesseResult IpAddress(IDockerMachineProcesseModel dockerMachineProcesseModel);

        IDockerMachineProcesseResult Kill(IDockerMachineProcesseModel dockerMachineProcesseModel);

        IDockerMachineProcesseResult Machines(IDockerMachineProcesseModel dockerMachineProcesseModel);

        IDockerMachineProcesseResult Provision(IDockerMachineProcesseModel dockerMachineProcesseModel);

        IDockerMachineProcesseResult RegenerateCerts(IDockerMachineProcesseModel dockerMachineProcesseModel);

        IDockerMachineProcesseResult Restart(IDockerMachineProcesseModel dockerMachineProcesseModel);

        IDockerMachineProcesseResult RemoveMachine(IDockerMachineProcesseModel dockerMachineProcesseModel);

        IDockerMachineProcesseResult SSH(IDockerMachineProcesseModel dockerMachineProcesseModel);

        IDockerMachineProcesseResult Scp(IDockerMachineProcesseModel dockerMachineProcesseModel);

        IDockerMachineProcesseResult Start(IDockerMachineProcesseModel dockerMachineProcesseModel);

        IDockerMachineProcesseResult Status(IDockerMachineProcesseModel dockerMachineProcesseModel);

        IDockerMachineProcesseResult Stop(IDockerMachineProcesseModel dockerMachineProcesseModel);

        IDockerMachineProcesseResult Upgrade(IDockerMachineProcesseModel dockerMachineProcesseModel);

        IDockerMachineProcesseResult Url(IDockerMachineProcesseModel dockerMachineProcesseModel);

        IDockerMachineProcesseResult Version(IDockerMachineProcesseModel dockerMachineProcesseModel);

        IDockerMachineProcesseResult Help(IDockerMachineProcesseModel dockerMachineProcesseModel);
    }
}
