window.getScrollInfo = (selector) => {
    const el = document.querySelector(selector);
    return {
        ScrollTop: el.scrollTop,
        ScrollHeight: el.scrollHeight,
        ClientHeight: el.clientHeight
    };
};