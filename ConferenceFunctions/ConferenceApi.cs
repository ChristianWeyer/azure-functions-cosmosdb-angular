using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace ConferenceFunctions
{
    public static class ConferenceApi
    {
        [FunctionName("ListSessions")]
        public static IEnumerable<SessionOverview> ListSessions(
            [HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "sessions")]
            HttpRequestMessage req,
            [DocumentDB("conferencesdemo", "sessionsx", SqlQuery = "SELECT c.id, c.title FROM c", ConnectionStringSetting = "ConferencesDb")]
            IEnumerable<SessionOverview> sessions,
            TraceWriter log)
        {
            log.Info("ListSessions function processed a request.");

            return sessions;
        }

        [FunctionName("GetSessionDetails")]
        public static SessionDetails GetSession(
            [HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "sessions/{id}")]
            HttpRequestMessage req,
            [DocumentDB("conferencesdemo", "sessionsx", Id = "{id}", ConnectionStringSetting = "ConferencesDb")]
            SessionDetails session,
            TraceWriter log)
        {
            log.Info("GetSession function processed a request: " + session.Id);

            return session;
        }

        [FunctionName("AddSession")]
        public static async Task<HttpResponseMessage> AddSession(
            [HttpTrigger(AuthorizationLevel.Anonymous, "POST", Route = "sessions")]
            SessionDetails session,
            [DocumentDB("conferencesdemo", "sessionsx", Id="Id", ConnectionStringSetting = "ConferencesDb")]
            IAsyncCollector<SessionDetails> documents,
            TraceWriter log)
        {
            log.Info("AddSession function processed a request: " + session.Id);

            await documents.AddAsync(session);

            return await Task.FromResult(new HttpResponseMessage(HttpStatusCode.Created));
        }
    }
}
