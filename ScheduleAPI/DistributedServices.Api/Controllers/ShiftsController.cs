using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Infrastructure.CrossCutting.IoC;
using DistributedServices.Entities;
using DistributedServices.Api.Mappings;
using Infrastructure.Data.MainModule.Repositories;
using Infrastructure.Data.MainModule.Models;

namespace DistributedServices.Api.Controllers
{
    public class ShiftsController : ApiController
    {
        private readonly IShiftRepository _repository;

        public ShiftsController()
        {
            _repository = IoCFactory.Resolve<IShiftRepository>();
        }

        /// <summary>
        /// All of the items.
        /// </summary>
        /// <returns>All items.</returns>
        public HttpResponseMessage GetAll([FromUri]string clientToken)
        {
            var items = _repository.List(clientToken);

            var itemDto = items.Select(i => Mapper.Map(i));

            return Request.CreateResponse(HttpStatusCode.OK, itemDto);
        }

        /// <summary>
        /// A item.
        /// </summary>
        /// <param name="id">Unique identifier for an item.</param>
        /// <returns>Employee title.</returns>
        public HttpResponseMessage Get([FromUri]int id, [FromUri]string clientToken)
        {
            var item = _repository.Get(id, clientToken);

            var itemDto = Mapper.Map(item);

            return Request.CreateResponse(HttpStatusCode.OK, itemDto);
        }

        /// <summary>
        /// Creates a new item.
        /// </summary>
        /// <param name="item">New item to create in the given bundle.</param>
        /// <returns>The recently created item.</returns>
        public HttpResponseMessage Post([FromBody]Shift item, [FromUri]string clientToken)
        {
            if (item == null)
                return Request.CreateResponse(HttpStatusCode.OK, new Shift());

            var itemDto = Mapper.Map(_repository.Add(item, clientToken));

            return Request.CreateResponse(HttpStatusCode.OK, itemDto);
        }

        /// <summary>
        /// Updates an existing item.
        /// </summary>
        /// <param name="id">Unique identifier for the item to update.</param>
        /// <param name="item">Item to update.</param>
        /// <returns>The recently updated item.</returns>
        public HttpResponseMessage Put([FromUri]int id, [FromBody]Shift item, [FromUri]string clientToken)
        {
            if (item == null)
                return Request.CreateResponse(HttpStatusCode.OK, new Shift());

            item.Id = id;

            var itemDto = Mapper.Map(_repository.Update(item, clientToken));

            return Request.CreateResponse(HttpStatusCode.OK, itemDto);
        }

        /// <summary>
        /// Deletes an existing item.
        /// </summary>
        /// <param name="id">Unique identifier for an item.</param>
        /// <returns>The recently deleted item.</returns>
        public HttpResponseMessage Delete([FromUri]int id, [FromUri]string clientToken)
        {
            var itemDto = Mapper.Map(_repository.Delete(id, clientToken));

            return Request.CreateResponse(HttpStatusCode.OK, itemDto);
        }
    }
}
