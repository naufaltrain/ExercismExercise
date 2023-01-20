class Lasagna
{
       
         int NormalMinutes = 40; // Define
    // TODO: define the 'ExpectedMinutesInOven()' method
  public int ExpectedMinutesInOven(){
               return NormalMinutes; // output = 40
    }

    // TODO: define the 'RemainingMinutesInOven()' method
public int RemainingMinutesInOven(int RemainingMinutes){
    return NormalMinutes - RemainingMinutes; // 40 - inserted number(30)
}

    // TODO: define the 'PreparationTimeInMinutes()' method
public int PreparationTimeInMinutes(int PreparelayerMinutes){
    return PreparelayerMinutes * 2; // each layer (layer is insert in test) takes 2 minutes, hence the multiply of 2
}

    // TODO: define the 'ElapsedTimeInMinutes()' method
public int ElapsedTimeInMinutes( int PreparelayerMinutes, int RemainingMinutes ){

    return RemainingMinutes + PreparelayerMinutes*2; // total minutes use to creat a lasagna
}
    
}
