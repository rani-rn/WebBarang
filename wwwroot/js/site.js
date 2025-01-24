document.addEventListener("DOMContentLoaded", function () {
    const sidebarToggle = document.querySelector("#sidebar-toggle");
    const sidebar = document.querySelector("#sidebar");

    // Toggle sidebar
    if (sidebarToggle && sidebar) {
        sidebarToggle.addEventListener("click", function () {
            sidebar.classList.toggle("collapsed");
        });
    }

    // Handle partial form loading
    const loadPartialButtons = document.querySelectorAll("[data-load-partial]");

    if (loadPartialButtons) {
        loadPartialButtons.forEach((button) => {
            button.addEventListener("click", function (event) {
                event.preventDefault();
                const url = this.getAttribute("data-url");
                const target = this.getAttribute("data-target");

                if (url && target) {
                    fetch(url)
                        .then((response) => {
                            if (!response.ok) {
                                throw new Error("Failed to load partial view.");
                            }
                            return response.text();
                        })
                        .then((html) => {
                            document.querySelector(target).innerHTML = html;
                        })
                        .catch((error) => {
                            console.error("Error loading partial view:", error);
                        });
                }
            });
        });
    }
});

