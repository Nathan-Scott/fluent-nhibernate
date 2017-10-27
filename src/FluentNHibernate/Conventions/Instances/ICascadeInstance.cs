using FluentNHibernate.Conventions.Inspections;

namespace FluentNHibernate.Conventions.Instances
{
    public interface ICascadeInstance
    {
        void All();
        void None();
        void SaveUpdate();
        void SaveUpdateMerge();
        void Delete();
        void Merge();
    }
}