namespace com.smerkel.IDockerProcess
{
    using System.Collections.Generic;
    using Models;
    using Results;

    public interface IDockerProcess
    {
        IDockerProcesseResult Attach(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Build(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Commit(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult CopyFiles(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Create(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Diff(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Events(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Exec(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Export(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult History(IDockerProcesseModel dockerProcesseModel);

        IEnumerable<IDockerProcessImagesResult> Images(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Import(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Info(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Inspect(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Kill(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Load(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Login(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Logout(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Logs(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Pause(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Port(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult ListContainers(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Pull(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Push(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Rename(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Restart(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult RemoveContainers(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult RemoveImages(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Run(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Save(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Search(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Start(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Stats(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Stop(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Tag(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Top(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Unpause(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Version(IDockerProcesseModel dockerProcesseModel);

        IDockerProcesseResult Wait(IDockerProcesseModel dockerProcesseModel);
    }
}
