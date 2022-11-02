using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace vpe.math.domain;
public class FullyRealizedObservation
{
    public Guid Id;
    public IInfroObserver observerSystem;
    public SyntaxToken coreIncident; //?SyntaxToken?
    public CSharpSyntaxTree breakDown;
    public FullyRealizedObservation(IInfroObserver observerSystem, SyntaxToken coreIncident, CSharpSyntaxTree breakDown)
    {
        this.observerSystem = observerSystem;
        this.coreIncident = coreIncident;
        this.breakDown = breakDown;
    }
}
