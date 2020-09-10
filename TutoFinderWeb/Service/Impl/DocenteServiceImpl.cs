using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TutoFinder.Commons;
using TutoFinder.Dto;
using TutoFinder.Entity;
using TutoFinder.Persistence;

namespace TutoFinder.Service.Impl
{
    public class DocenteServiceImpl : DocenteService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public DocenteServiceImpl(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<DocenteDto> Create(DocenteCreateDto model)
        {
            var entry = new Docente
            {
                Nombres = model.Nombres,
                Apellidos = model.Apellidos,
                DNI = model.DNI,
                Domicilio = model.Domicilio,
                Correo = model.Correo,
                Status_Disponibilidad = model.Status_Disponibilidad,                Numero_cuenta = model.Numero_cuenta,
                Costo = model.Costo,
                Status_Membresia = model.Status_Membresia

            };

            if (model.Status_Disponibilidad == true)
                entry.Disponibilidad = "Disponible";
            else if (model.Status_Disponibilidad == false)
                entry.Disponibilidad = "No Disponible";

            if (model.Status_Membresia == true)
                entry.Membresia = "Activa";
            else if (model.Status_Membresia == false)
                entry.Membresia = "No Activa";

            await _context.AddAsync(entry);
            await _context.SaveChangesAsync();

            return _mapper.Map<DocenteDto>(entry);
        }
        public async Task Remove(int id)
        {
            _context.Remove(new Docente
            {
                DocenteId = id
            });
            await _context.SaveChangesAsync();
        }

        public async Task Update(int id, DocenteUpdateDto model)
        {
            var entry = await _context.Docentes.SingleAsync(x => x.DocenteId == id);
            entry.Nombres = model.Nombres;
            entry.Apellidos = model.Apellidos;
            entry.DNI = model.DNI;
            entry.Domicilio = model.Domicilio;
            entry.Correo = model.Correo;
            entry.Costo = model.Costo;
            entry.Status_Disponibilidad = model.Status_Disponibilidad;
            if (model.Status_Disponibilidad == true)
                entry.Disponibilidad = "Disponible";
            else if (model.Status_Disponibilidad == false)
                entry.Disponibilidad = "No Disponible";
            entry.Numero_cuenta = model.Numero_cuenta;
            entry.Status_Membresia = model.Status_Membresia;
            if (model.Status_Membresia == true)
                entry.Membresia = "Activa";
            else if (model.Status_Membresia == false)
                entry.Membresia = "No Activa";
            await _context.SaveChangesAsync();
        }
        public async Task<DataCollection<DocenteDto>> GetAll(int page, int take)
        {
            return _mapper.Map<DataCollection<DocenteDto>>(
                await _context.Docentes
                .OrderByDescending(x => x.DocenteId)
                .AsQueryable()
                .PagedAsync(page, take));
        }
        public async Task<DocenteDtoPresentar> GetById(int id)
        {
            return _mapper.Map<DocenteDtoPresentar>(
                await _context.Docentes.SingleAsync(x => x.DocenteId == id));
        }
        public bool Existencia(int id)
        {
            if (_context.Docentes.Where(x => x.DocenteId == id).FirstOrDefault() == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
