// The accepted roles for a user
namespace ProjectTracker.API.Enums
{
    /// <summary>
    /// A user can either be a Customer Success Specialist (CSS), Implementation Specialist (IMP), Manager
    /// or ViewOnly (other user e.g. sales rep)
    /// </summary>
    public enum UserRole
    {
        CSS, IMP, Manager, ViewOnly
    }

    /// <summary>
    /// This represents the AI's progress with a project's spreadsheet. 
    /// It can either be in progress, be completed, stopped due to error, or never attempted (no features applicable)
    /// </summary>
    public enum AIProgress
    {
        InProgress, Completed, Error, NoAttempt
    }

    /// <summary>
    /// This is the status of the current project
    /// </summary>
    public enum Status
    {
        Pending, InProgress, Completed, Cancelled
    }
}
