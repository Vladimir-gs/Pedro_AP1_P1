using Pedro_AP1_P1.DAL;
using Pedro_AP1_P1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Pedro_AP1_P1.BLL
{
    public class AportesBLL
    {
        private readonly Context _context;

        public AportesBLL(Context context){
            _context = context;
        }

        public bool Existe(int AportesId)
        {
            return _context.Aportes.Any(op => op.AportesId == AportesId);
        }

        public bool Insertar(Aportes aportes){
            _context.Aportes.Add(aportes);
            return _context.SaveChanges() > 0;           
        }

        public bool Actualizar(Aportes aportes)
        {
            _context.Aportes.Update(aportes);
            return _context.SaveChanges() > 0;
        }

        public bool Eliminar(Aportes aportes)
        {
            _context.Aportes.Remove(aportes);
            return _context.SaveChanges() > 0;
        }

        public bool Guardar(Aportes aportes){
            if(!Existe(aportes.AportesId)){
                return Insertar(aportes);
            }else{
                return Actualizar(aportes);
            }
        }

        public Aportes? Buscar (int AportesId){
            return _context.Aportes
            .AsNoTracking()
            .FirstOrDefault(s => s.AportesId == AportesId);
        }

        public List<Aportes> GetList(Expression<Func<Aportes, bool>> Criterio){
            return _context.Aportes
            .Where(Criterio)
            .AsNoTracking()
            .ToList();
        }

        public bool Validar(int aporte){
            bool confirmar = false;

            confirmar = _context.Aportes.Any(x => x.AportesId == aporte);
            return confirmar;
        }
    }
}