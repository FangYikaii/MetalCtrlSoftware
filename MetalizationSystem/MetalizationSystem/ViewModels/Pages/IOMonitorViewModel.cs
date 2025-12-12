namespace MetalizationSystem.ViewModels;

public partial class IOMonitorViewModel : ObservableObject
{



    [ObservableProperty]
    int[] _inPutIndex1 = new int[16];
    [ObservableProperty]
    string[] _inPutName1 = new string[16];
    [ObservableProperty]
    int[] _inPutIndex2 = new int[16];
    [ObservableProperty]
    string[] _inPutName2 = new string[16];
    [ObservableProperty]
    int[] _inPutIndex3 = new int[16];
    [ObservableProperty]
    string[] _inPutName3 = new string[16];
    [ObservableProperty]
    int[] _inPutIndex4 = new int[16];
    [ObservableProperty]
    string[] _inPutName4 = new string[16];

    [ObservableProperty]
    int[] _outPutIndex1 = new int[16];
    [ObservableProperty]
    string[] _outPutName1 = new string[16];
    [ObservableProperty]
    int[] _outPutIndex2 = new int[16];
    [ObservableProperty]
    string[] _outPutName2 = new string[16];

    [ObservableProperty]
    int[] _outPutIndex3 = new int[16];
    [ObservableProperty]
    string[] _outPutName3 = new string[16];
    [ObservableProperty]
    int[] _outPutIndex4 = new int[16];
    [ObservableProperty]
    string[] _outPutName4 = new string[16];

    public IOMonitorViewModel()
    {
        int[][] ip = new int[4][];
        string[][] ipn = new string[4][];

      

        int[][] op = new int[4][];
        string[][] opn = new string[4][];

    

        for(int j =0; j < 4; j++)
        {
            ip[j] = new int[16];
            ipn[j] = new string[16];
            op[j] = new int[16];
            opn[j] = new string[16];
            for (int i = 0; i < 16; i++)
            {
                ip[j][i] = j * 16 + i;
                ipn[j][i] = XMachine.Instance.Card.FindDi(j * 16 + i).Name;

                op[j][i] = j * 16 + i;
                opn[j][i] = XMachine.Instance.Card.FindDo(j * 16 + i).Name;
            }
        }
        
        InPutIndex1 = ip[0];
        InPutName1 = ipn[0];
        OutPutIndex1 = op[0];
        OutPutName1 = opn[0];

        InPutIndex2 = ip[1];
        InPutName2 = ipn[1];
        OutPutIndex2 = op[1];
        OutPutName2 = opn[1];

        InPutIndex3 = ip[2];
        InPutName3 = ipn[2];
        OutPutIndex3 = op[2];
        OutPutName3 = opn[2];

        InPutIndex4 = ip[3];
        InPutName4 = ipn[3];
        OutPutIndex4 = op[3];
        OutPutName4 = opn[3];

    }



}
