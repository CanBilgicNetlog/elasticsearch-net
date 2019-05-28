using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net;
using static Elasticsearch.Net.HttpMethod;

//This file is automatically generated from https://github.com/elastic/elasticsearch/tree/master/rest-api-spec
namespace Elasticsearch.Net
{
	///<summary> Raw operations with elasticsearch </summary>
	public class TasksClient : NamespacedClientProxy
	{
		public TasksClient(ElasticLowLevelClient client): base(client)
		{
		}

		///<summary>POST on /_tasks/_cancel <para>http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse CancelTasks<TResponse>(CancelTasksRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(POST, "_tasks/_cancel", null, RequestParams(requestParameters));
		///<summary>POST on /_tasks/_cancel <para>http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> CancelTasksAsync<TResponse>(CancelTasksRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(POST, "_tasks/_cancel", ctx, null, RequestParams(requestParameters));
		///<summary>POST on /_tasks/{task_id}/_cancel <para>http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html</para></summary>
		///<param name = "task_id">Cancel the task with specified task id (node_id:task_number)</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse CancelTasks<TResponse>(string task_id, CancelTasksRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(POST, Url($"_tasks/{task_id:task_id}/_cancel"), null, RequestParams(requestParameters));
		///<summary>POST on /_tasks/{task_id}/_cancel <para>http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html</para></summary>
		///<param name = "task_id">Cancel the task with specified task id (node_id:task_number)</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> CancelTasksAsync<TResponse>(string task_id, CancelTasksRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(POST, Url($"_tasks/{task_id:task_id}/_cancel"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_tasks/{task_id} <para>http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html</para></summary>
		///<param name = "task_id">Return the task with specified id (node_id:task_number)</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetTask<TResponse>(string task_id, GetTaskRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(GET, Url($"_tasks/{task_id:task_id}"), null, RequestParams(requestParameters));
		///<summary>GET on /_tasks/{task_id} <para>http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html</para></summary>
		///<param name = "task_id">Return the task with specified id (node_id:task_number)</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> GetTaskAsync<TResponse>(string task_id, GetTaskRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_tasks/{task_id:task_id}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_tasks <para>http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse ListTasks<TResponse>(ListTasksRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(GET, "_tasks", null, RequestParams(requestParameters));
		///<summary>GET on /_tasks <para>http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> ListTasksAsync<TResponse>(ListTasksRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(GET, "_tasks", ctx, null, RequestParams(requestParameters));
	}
}