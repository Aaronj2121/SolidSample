using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;

//namespace ArdalisRating
//{
    //public class DefaultRatingContext : IRatingContext
    //{
    //    public RatingEngine Engine { get; set; }
    //    private readonly IPolicySource _policySource;
    //    private readonly IPolicySerializer _policySerializer;

    //    public DefaultRatingContext(IPolicySource policySource, 
    //        IPolicySerializer policySerializer)
    //    {
    //        _policySource = policySource;
    //        _policySerializer = policySerializer;
    //    }

    //    public Rater CreateRaterForPolicy(Policy policy, IRatingContext context)
    //    {
    //        return new RaterFactory(new RatingUpdater(context.Engine)).Create(policy);
    //    }

    //    public Policy GetPolicyFromJsonString(string policyJson)
    //    {
    //        return _policySerializer.GetPolicyFromString(policyJson);
    //    }

    //    public Policy GetPolicyFromXmlString(string policyXml)
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public string LoadPolicyFromFile()
    //    {
    //        return _policySource.GetPolicyFromSource();
    //    }

    //    public string LoadPolicyFromURI(string uri)
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public void Log(string message)
    //    {
    //        new ConsoleLogger().Log(message);
    //    }

    //    public void UpdateRating(decimal rating)
    //    {
    //        new RatingUpdater(Engine).UpdateRating(rating);
    //    }
//    }
//}