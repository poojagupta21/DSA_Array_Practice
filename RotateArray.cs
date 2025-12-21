public class RotateArray{

    public static void Rotate(int[] arr, int d) {
        int n  = arr.Length;
        d%=n;
        int noOfCycles = GCD(n,d);

        for(int i = 0 ;i < noOfCycles;i++){
            int currIdx = i;
            int currEle = arr[currIdx];

            do{
                int nextIdx = (currIdx + d)%n;
                int nextEle = arr[nextIdx];

                arr[nextIdx] = currEle;

                currEle = nextEle;

                currIdx = nextIdx;
            }while(currIdx != i);
        }
    }

    public static int GCD( int n , int d){
        while(d!=0){
            int temp = d;
            d = n%d;
            n = temp;
        }
        return n;
    }
}