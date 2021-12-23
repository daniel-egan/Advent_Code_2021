fn main() {
    let drawn = "7,4,9,5,11,17,23,2,0,14,21,24,10,16,13,6,15,25,12,22,18,20,8,19,3,26,1";
    let boards = "22 13 17 11  0
     8  2 23  4 24
    21  9 14 16  7
     6 10  3 18  5
     1 12 20 15 19
     3 15  0  2 22
     9 18 13 17  5
    19  8  7 25 23
    20 11 10 24  4
    14 21 16 12  6
    14 21 17 24  4
    10 16 15  9 19
    18  8 23 26 20
    22 11 13  6  5
     2  0 12  3  7";

     let mut drawnSplit = drawn.split(",");
    let drawnVec: Vec<&str> = drawnSplit.collect();

    let mut boardSplit = boards.split_whitespace();
    let boardsVec: Vec<&str> = boardSplit.collect();

    let mut i = 0;
    loop {
        let mut value1 = boardsVec[i];
        let mut value2 = boardsVec[i + 1];
        let mut value3 = boardsVec[i + 2];
        let mut value4 = boardsVec[i + 3];
        let mut value5 = boardsVec[i + 4];

        let my_string = value1.to_string(); // `parse()` works with `&str` and `String`!
        let my_int = my_string.parse::<i32>().unwrap();

        i += 5;
        if i == 75{
            break;
        }
    }

    println!("{}", 1);
}