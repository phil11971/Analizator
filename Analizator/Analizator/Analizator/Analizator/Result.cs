namespace Analizator
{
    public enum Err
    {
        NoError,
        UnknownError,
        IdReservedError,
        OverflowCharacters,
        OutOfRange,
        VarExpected,
        OfExpected,
        IdOrKeywordExpected,
        IdExpected,
        СolonExpected,
        SemicolonExpected,
        СonstantExpected,
        NotFoundTypeOfConstantExpected,
        OpenBracketsExpected,
        CloseBracketsExpected,
        IdTypeVarExpected

    }

    class Result
    {
        int ErrPos;
        Err Err;
        string _Str;

        public Result(int ErrPos, Err Err, string Value)
        {
            this.ErrPos = ErrPos;
            this.Err = Err;
            _Str = Value;
        }

        public int ErrPosition
        {
            get
            {
                return ErrPos;
            }
        }

        public string ErrMessage
        {
            get
            {
                switch (Err)
                {
                    case Err.NoError:
                        {
                            return "Нет ошибок";
                        }
                    case Err.UnknownError:
                        {
                            return "Неизвестная ошибка";
                        }
                    case Err.IdReservedError:
                        {
                            return "Ид-р - зарезервированное слово";
                        }
                    case Err.OverflowCharacters:
                        {
                            return "кол-во символов в идентиф-ре превышает 8";
                        }
                    case Err.OutOfRange:
                        {
                            return "целая константа вне диапазона 0 - 255";
                        }
                    case Err.VarExpected:
                        {
                            return "ожидалось кл.слово VAR";
                        }
                    case Err.OfExpected:
                        {
                            return "ожидалось кл.слово OF";
                        }
                    case Err.IdOrKeywordExpected:
                        {
                            return "ожидался идентиф-р или кл. слово";
                        }
                    case Err.IdExpected:
                        {
                            return "ожидался идентиф-р";
                        }
                    case Err.СolonExpected:
                        {
                            return "ожидалось двоеточие";
                        }
                    case Err.SemicolonExpected:
                        {
                            return "ожидалась точка с зпт";
                        }
                    case Err.СonstantExpected:
                        {
                            return "ожидалась целая константа";
                        }
                    case Err.NotFoundTypeOfConstantExpected:
                        {
                            return "такого типа константы нет";
                        }
                    case Err.OpenBracketsExpected:
                        {
                            return "ожидалась открывающая скобка";
                        }
                    case Err.CloseBracketsExpected:
                        {
                            return "ожидалась закрывающая скобка";
                        }
                    case Err.IdTypeVarExpected:
                        {
                            return "совпадение ид ра типа и пер ой";
                        }
                    default:
                        {
                            return "Неизвестная ошибка";
                        }
                }
            }
        }

        public string Str
        {
            get
            {
                return _Str;
            }
        }
    }
}
