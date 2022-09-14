using Fluxor.Blazor.Web.Middlewares.Routing;
using Fluxor;

namespace RoutingErrorsAndFluxor.Shared.Store;

public class ResetAppError
{
    public class ActionReducer : Reducer<AppErrorState, GoAction>
    {
        public override AppErrorState Reduce(AppErrorState state, GoAction action) =>
            AppErrorState.Empty();
    }
}
