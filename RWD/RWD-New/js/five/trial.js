 function showColor() {
            // let clrs = ["red", "pink", "green", "wheat", "black", "blue", "blueviolet", "yellow", "aqua", "brown"];

            const select = document.getElementById('num');
            const div = document.getElementById('div');
            let color;
            // div.style.backgroundColor = clrs[select.value - 1];

            switch (parseInt(select.value)) {
                case 1:
                    color = "red";
                    break;

                case 2:
                    color = "pink";
                    break;

                case 3:
                    color = "green";
                    break;

                case 4:
                    color = "wheat";
                    break;

                case 5:
                    color = "red";
                    break;

                case 6:
                    color = "pink";
                    break;

                case 7:
                    color = "green";
                    break;

                case 8:
                    color = "wheat";
                    break;
            }

            // document.body.style.backgroundColor = color;
            div.style.backgroundColor = color;
        }
