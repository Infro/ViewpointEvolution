namespace vpe.math.domain;

public interface ISharable
{
    //Takes an observationa 
    public IEnumerable<IObserver> SharedWith(BaseObservation origin)
    {
        throw new NotImplementedException();
    }
}
