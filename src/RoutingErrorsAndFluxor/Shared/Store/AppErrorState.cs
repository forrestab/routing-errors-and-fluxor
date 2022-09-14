using Fluxor;

namespace RoutingErrorsAndFluxor.Shared.Store;

[FeatureState]
public class AppErrorState
{
    public IEnumerable<string>? ErrorMessages { get; private set; }

    public bool HasErrors
    {
        get { return this.ErrorMessages is not null || this.ErrorMessages?.Count() < 0; }
    }

    public static AppErrorState Empty() =>
        new AppErrorState();

    private AppErrorState()
    {
        this.ErrorMessages = null;
    }

    public AppErrorState(IEnumerable<string> errorMessages)
    {
        this.ErrorMessages = errorMessages;
    }
}
