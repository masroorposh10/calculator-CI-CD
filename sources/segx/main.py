from dotenv import load_dotenv
import os

load_dotenv()


def write_file(data):
    with open("file.txt", "w") as file:
        file.write(data)


if os.getenv("ENV") == "value_for_the_key":
    write_file("ENV is correct")
else:
    write_file("ENV not correct")
print("Hello World")
for i in range(len(10)):
    print(i)

print(Hi)

for x in range(len(10)):
    print(x)

pribt("Hello World")