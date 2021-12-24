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
    let drawnLen = drawnVec.len();

    let mut boardSplit = boards.split_whitespace();
    let mut boardsVec: Vec<&str> = boardSplit.collect();
    let boardsLen = boardsVec.len();

    let mut j = 0;
    let mut found = false;
    let mut foundValue: u32 = 0;
    let mut drawnValue = "";
    loop {
        // This will run through the loop of all drawn numbers
        drawnValue = drawnVec[j];
        let mut i = 0;
        loop {
            let mut value1 = boardsVec[i];
            let mut value2 = boardsVec[i + 1];
            let mut value3 = boardsVec[i + 2];
            let mut value4 = boardsVec[i + 3];
            let mut value5 = boardsVec[i + 4];

            // Check if two strings are equal
            // String from drawnSplit and string value1, value2

            if drawnValue == value1 {
                boardsVec[i] = "null";
            }

            if drawnValue == value2 {
                boardsVec[i + 1] = "null";
            }

            if drawnValue == value3 {
                boardsVec[i + 2] = "null";
            }

            if drawnValue == value4 {
                boardsVec[i + 3] = "null";
            }

            if drawnValue == value5 {
                boardsVec[i + 4] = "null";
            }

            i += 5;
            if i == boardsLen {
                break;
            }
        }

        // Check if there is a line horizontally that has all null characters
        let mut checkerI = 0;
        loop {
            if boardsVec[checkerI] == "null" {
                if boardsVec[checkerI + 1] == "null" {
                    if boardsVec[checkerI + 2] == "null" {
                        if boardsVec[checkerI + 3] == "null" {
                            if boardsVec[checkerI + 4] == "null" {
                                found = true;
                                foundValue = checkerI as u32;
                                break;
                            } else {
                                checkerI += 5;
                            }
                        } else {
                            checkerI += 5;
                        }
                    } else {
                        checkerI += 5;
                    }
                } else {
                    checkerI += 5;
                }
            } else {
                checkerI += 5;
            }
            if checkerI == boardsLen {
                break;
            }
        }

        // Need to check vertical values here

        checkerI = 0;
        loop {
            if boardsVec[checkerI] == "null" {
                if boardsVec[checkerI + 5] == "null" {
                    if boardsVec[checkerI + 10] == "null" {
                        if boardsVec[checkerI + 15] == "null" {
                            if boardsVec[checkerI + 20] == "null" {
                                found = true;
                                foundValue = checkerI as u32;
                                break;
                            } else {
                                checkerI += 25;
                            }
                        } else {
                            checkerI += 25;
                        }
                    } else {
                        checkerI += 25;
                    }
                } else {
                    checkerI += 25;
                }
            } else {
                checkerI += 25;
            }
            if checkerI == boardsLen {
                break;
            }
        }





        // If there is then break out and say which board has that value
        if found == true {
            break;
        }
        // If there isn't then increment j
        j += 1;
        if j == drawnLen {
            break;
        }
    }

    // Currently the start of the row that has been drawn fully is in foundValue. Now find which board that value belongs to
    // This can be done by taking 24 away until the number is negative, e.g. row 19,8,13,17,5 would be starting from boardsVec[35]
    // This would mean 35 - 24 = 11 -> 11 - 24 = -13
    // This is done twice meaning the second board
    // If the start of the line is boardsVec[50]
    // 50 - 24 = 26 -> 26 - 24 = 2 -> 2 - 24 = -22
    // This is done 3 times meaning the third board
    let mut whichBoard = 0;
    loop {
        if foundValue > 24 {
            foundValue = foundValue - 24;
            whichBoard = whichBoard + 1;
        }
        if foundValue <= 24 {
            whichBoard = whichBoard + 1;
            break;
        }
    }

    // Add the rest of the values within the board in order to get the final answer
    // Start at (whichBoard - 1) * 25
    // Add the next 24 values that are not null
    let startValue = (whichBoard - 1) * 25;
    let mut totalValue = 0;
    for i in 0..24 {
        if boardsVec[i + startValue] != "null" {
            let boardsVecu32: u32 = boardsVec[i + startValue].parse().unwrap();
            totalValue = boardsVecu32 + totalValue;
        }
    }

    // Multiply the totalValue of the rest of the board by the last drawn number
    let drawnValueu32: u32 = drawnValue.parse().unwrap();
    let boardValue = totalValue * drawnValueu32;

    println!("{}", boardValue);
}
