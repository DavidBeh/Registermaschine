// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public abstract class Registermaschine {

    private Registermaschine() {
        LadeBefehle();
    }
    
    private class Befehl {
        internal Aktion Aktion;
        internal int Arg;
        public Befehl(Aktion aktion, int arg)
        {
            this.Aktion = aktion;
            Arg = arg;
        }
    }

    private enum Aktion {
        LOAD,
        DLOAD,
        STORE,
        ADD,
        SUB,
        MULT,
        DIV,
        JUMP,
        JGE,
        JGT,
        JLE,
        JLT,
        JEQ,
        JNE,
        END
    }

    private List<Befehl> Befehlsregister = new();
    private Dictionary<int, int> Datenregister = new();
    
    d
    
    private int Akkumulator = 0;
    public abstract void LadeBefehle();
    

    public void Starte() {
        int PC = 0;
        while (PC < Befehlsregister.Count) {
            Befehl b = Befehlsregister[PC];
            switch (b.Aktion) {
                case Aktion.LOAD:
                    break;
                case Aktion.DLOAD:
                    break;
                case Aktion.STORE:
                    break;
                case Aktion.ADD:
                    break;
                case Aktion.SUB:
                    break;
                case Aktion.MULT:
                    break;
                case Aktion.DIV:
                    break;
                case Aktion.JUMP:
                    break;
                case Aktion.JGE:
                    break;
                case Aktion.JGT:
                    break;
                case Aktion.JLE:
                    break;
                case Aktion.JLT:
                    break;
                case Aktion.JEQ:
                    break;
                case Aktion.JNE:
                    break;
                case Aktion.END:
                    break;
                default:
                    break;
            }
        }
    }

    protected int LOAD(int x) {
        Befehlsregister.Add(new Befehl(Aktion.LOAD, x));
        return Befehlsregister.Count;
    }
    protected int DLOAD(int i) {
        Befehlsregister.Add(new Befehl(Aktion.DLOAD, i));
        return Befehlsregister.Count;

    }

    protected int STORE(int x) {
        Befehlsregister.Add(new Befehl(Aktion.STORE, x));
        return Befehlsregister.Count;
    }

    protected int ADD(int x) {
        Befehlsregister.Add(new Befehl(Aktion.ADD, x));
        return Befehlsregister.Count;
    }

    protected int SUB(int x) {
        Befehlsregister.Add(new Befehl(Aktion.SUB, x));
        return Befehlsregister.Count;
    }

    protected int MULT(int x) {
        Befehlsregister.Add(new Befehl(Aktion.MULT, x));
        return Befehlsregister.Count;
    }

    protected int DIV(int x) {
        Befehlsregister.Add(new Befehl(Aktion.DIV, x));
        return Befehlsregister.Count;
    }

    protected int JUMP(int n) {
        Befehlsregister.Add(new Befehl(Aktion.JUMP, n));
        return Befehlsregister.Count;
    }

    protected int JGE(int n) {
        Befehlsregister.Add(new Befehl(Aktion.JGE, n));
        return Befehlsregister.Count;
    }

    protected int JGT(int n) {
        Befehlsregister.Add(new Befehl(Aktion.JGT, n));
        return Befehlsregister.Count;
    }

    protected int JLE(int n) {
        Befehlsregister.Add(new Befehl(Aktion.JLE, n));
        return Befehlsregister.Count;
    }

    protected int JLT(int n) {
        Befehlsregister.Add(new Befehl(Aktion.JLT, n));
        return Befehlsregister.Count;
    }

    protected int JEQ(int n) {
        Befehlsregister.Add(new Befehl(Aktion.JEQ, n));
        return Befehlsregister.Count;
    }

    protected int JNE(int n) {
        Befehlsregister.Add(new Befehl(Aktion.JNE, n));
        return Befehlsregister.Count;
    }

    protected int END() {
        Befehlsregister.Add(new Befehl(Aktion.END, 0));
        return Befehlsregister.Count;
    }
}