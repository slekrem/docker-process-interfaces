namespace com.smerkel.IDockerProcess.Results
{
    public interface IDockerProcessImagesResult
    {
        string Repository { get; }
        
        string Tag { get; }
        
        string ImageId { get; }
        
        string Created { get; }
        
        string Size { get; }
    }
}