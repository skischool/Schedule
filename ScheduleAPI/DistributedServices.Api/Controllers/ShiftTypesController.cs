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
    public class ShiftTypesController : ApiController
    {
        private readonly IShiftTypeRepository _repository;

        public ShiftTypesController()
        {
            _repository = IoCFactory.Resolve<IShiftTypeRepository>();
        }

        /// <summary>
        /// All of the items.
        /// </summary>
        /// <returns>All items.</returns>
        //[GET("api/shifttypes")]
        public HttpResponseMessage GetAll()
        {
            var items = _repository.List();

            var itemDto = items.Select(i => Mapper.Map(i));

            return Request.CreateResponse(HttpStatusCode.OK, itemDto);
        }

        /// <summary>
        /// A item.
        /// </summary>
        /// <param name="id">Unique identifier for an item.</param>
        /// <returns>Employee title.</returns>
        public HttpResponseMessage Get([FromUri]int id)
        {
            var item = _repository.Get(id);

            var itemDto = Mapper.Map(item);

            return Request.CreateResponse(HttpStatusCode.OK, itemDto);
        }

        /// <summary>
        /// Creates a new item.
        /// </summary>
        /// <param name="item">New item to create in the given bundle.</param>
        /// <returns>The recently created item.</returns>
        public HttpResponseMessage Post([FromBody]ShiftType item)
        {
            if (item == null)
                return Request.CreateResponse(HttpStatusCode.OK, new ShiftType());

            var itemDto = Mapper.Map(_repository.Add(item));

            return Request.CreateResponse(HttpStatusCode.OK, itemDto);
        }

        /// <summary>
        /// Updates an existing item.
        /// </summary>
        /// <param name="id">Unique identifier for the item to update.</param>
        /// <param name="item">Item to update.</param>
        /// <returns>The recently updated item.</returns>
        public HttpResponseMessage Put([FromUri]int id, [FromBody]ShiftType item)
        {
            if (item == null)
                return Request.CreateResponse(HttpStatusCode.OK, new ShiftType());

            item.Id = id;

            var itemDto = Mapper.Map(_repository.Update(item));

            return Request.CreateResponse(HttpStatusCode.OK, itemDto);
        }

        /// <summary>
        /// Deletes an existing item.
        /// </summary>
        /// <param name="id">Unique identifier for an item.</param>
        /// <returns>The recently deleted item.</returns>
        public HttpResponseMessage Delete([FromUri]int id)
        {
            var itemDto = Mapper.Map(_repository.Delete(id));

            return Request.CreateResponse(HttpStatusCode.OK, itemDto);
        }
    }
}
