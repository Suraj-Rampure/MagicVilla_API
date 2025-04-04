﻿using AutoMapper;
using MagicVilla_Web.Models;
using MagicVilla_Web.Models.DTO;
using MagicVilla_Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MagicVilla_Web.Controllers
{
    public class VillaController : Controller
    {
        private readonly IVillaService _villaService;
        private readonly IMapper _mapper;

        public VillaController(IVillaService villaService, IMapper mapper)
        {
            _villaService = villaService;
            _mapper = mapper;
        }


        public async Task<IActionResult>  IndexVilla()
        {
            List<VillaDTO> list = new();

            var response = await _villaService.GetAllAsync<APIResponse>();

            if(response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.Result));
            }

            return View(list);
        }

        [HttpGet]
        public async Task<IActionResult> CreateVilla()
        {           
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateVilla(VillaCreateDTO model)
        {
           if(ModelState.IsValid)
            {
                var response = await _villaService.CreateAsync<APIResponse>(model);

                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(IndexVilla));
                }
            }

            return View(model);
        }
    }
}
