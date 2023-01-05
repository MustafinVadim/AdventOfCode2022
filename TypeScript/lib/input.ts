import axios from "axios";

export async function getInput(year: number, day: number): Promise<string> {
  try {
    let response = await axios.get<string>(`https://adventofcode.com/${year}/day/${day}/input`, {
      headers: {
          Cookie: "session="
      }});
  
    return response.data;
  
  } catch (error) {
    console.log(error);
  }

  return "";
}
