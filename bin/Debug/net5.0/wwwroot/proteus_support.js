/**
 * Javascript Support functions for Blazor proteus library
 * Proteus is a system for dynamic HTML displays which cna be laid out
 * on the fly
 */

var Proteus = {
    /**
     * @param {String} HTML representing a single element
     * @return {Element}
     * @example var td = htmlToElement('<td>foo</td>'),
     *              div = htmlToElement('<div><span>nested</span> <span>stuff</span></div>');
     */
    htmlToElement: function (html)
    {
        var template = document.createElement('template');
        html = html.trim(); // Never return a text node of whitespace as the result
        template.innerHTML = html;
        let el =document.body.appendChild(template.content.firstChild);
        return el;
    },
    
    
    /**
     * @param {String} HTML representing any number of sibling elements
     * @return {NodeList}
     * @example var rows = htmlToElements('<tr><td>foo</td></tr><tr><td>bar</td></tr>');
     */
    htmlToElements:function (tag,innerHtml)  {
        var template = document.createElement(tag);
        template.innerHTML = innerHtml;
        document.body.appendChild(template);
        return template.content.childNodes;
    },

    getElementSize: function( el ) {
       let domRect = el.getBoundingClientRect()

        return [domRect.width,domRect.height];
    },
    setElementParent(el,parent){
        parent.appendChild(el);
    },
    removeElementFromParent(el){
        el.parentNode.removeChild(el);
    },
    resetStyle(el,styles){
        for (const [key, value] of Object.entries(styles)) {
            el.style[key] = value;
        }
    },
    attachOnClick(el,objRef,methodname){
        el.onclick = () =>{
            objRef.invokeMethod(methodname);
        };
    },
    setMouseCallbacks(el,objRef,downMethodName,upMethodName,moveMethodName){
        function proteusMouseEvent(mouseEvt){
            return {
                ClientPosX: mouseEvt.offsetX,
                ClientPosY: mouseEvt.offsetY
            };
        }
        el.addEventListener("mousedown", (evt)=>{
            objRef.invokeMethod(downMethodName,proteusMouseEvent(evt));
        });
        el.addEventListener("mouseup", (evt)=>{
            objRef.invokeMethod(upMethodName,proteusMouseEvent(evt));
        });
        el.addEventListener("mousemove", (evt)=>{
            let pme = proteusMouseEvent(evt)
            console.log(pme);
            objRef.invokeMethod(moveMethodName,pme);
        });
    },
    log(str){
        console.log(str);
    }
 
}

