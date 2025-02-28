﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.concrete;

namespace Business.Abstract
{
    public interface IWriterService
    {
        List<Writer> getList();
        void WriterAdd(Writer writer);
        void WriterDelete(Writer writer);
        void WriterUpdate(Writer writer);
        Writer GetByID(int id);
    }
}
