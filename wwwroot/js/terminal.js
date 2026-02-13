// Terminal typing animation - character by character
window.terminalTyping = {
    start: function (elementId) {
        const container = document.getElementById(elementId);
        if (!container) return;
        container.innerHTML = '';

        const CHAR_DELAY = 28;       // ms per character
        const LINE_PAUSE = 350;      // pause between lines
        const CMD_CHAR_DELAY = 65;   // slower typing for the command
        const INITIAL_DELAY = 600;   // pause before typing starts

        // Terminal content definition
        // Each line is an array of segments: { text, type, href? }
        const prompt = 'sourabhsc@/home/sourabhsc/>$ ';
        const command = 'sourabhsc.ai -h';

        const outputLines = [
            [
                { text: '>$ ', type: 'caret' },
                { text: 'Highlights: ', type: 'label' },
                { text: 'Image segmentation on HST ULIRGs', type: 'link', href: 'https://sourabhsc.github.io/NULIRG' },
                { text: ', ', type: 'sep' },
                { text: 'A JHU covid challenge solution', type: 'link', href: 'http://dharavicovid.onrender.com/' }
            ],
            [
                { text: '>$ ', type: 'caret' },
                { text: 'Direct and indirect conference contributions: ', type: 'label' },
                { text: 'KM World 2022', type: 'link', href: 'https://www.kmworld.com/Articles/News/News/Squirro-and-Semantic-Web-Company-collaborate-to-create-a-Composite-AI-solution-156110.aspx' },
                { text: ', ', type: 'sep' },
                { text: 'KM World 2024', type: 'link', href: 'https://www.taxonomybootcamp.com/2024/Laura-Rodriguez.aspx' },
                { text: ', ', type: 'sep' },
                { text: 'IAEA conference presentation 2025', type: 'link', href: 'https://www.linkedin.com/posts/sourabh-singh-chauhan_etw2025-iaea-nuclearsafety-activity-7290863035924058115-glKw' },
                { text: ', ', type: 'sep' },
                { text: 'KM Summit Dublin 2025', type: 'link', href: 'https://www.linkedin.com/posts/helmutnagy_knowledgemanagement-knowledgesummitdublin-activity-7346256954538823681-XeZ3' }
            ],
            [
                { text: '>$ ', type: 'caret' },
                { text: 'Skills: ', type: 'label' },
                { text: 'Data Engineering, Knowledge Graph, Machine learning, Computer Vision, ETL, NLP, RAG', type: 'text' }
            ],
            [
                { text: '>$ ', type: 'caret' },
                { text: 'Hobbies: ', type: 'label' },
                { text: 'Badminton, Gardening, Travel', type: 'text' }
            ],
            [
                { text: '>$ ', type: 'caret' },
                { text: 'Alias: ', type: 'label' },
                { text: 'sourabhsc', type: 'text' }
            ]
        ];

        let totalDelay = INITIAL_DELAY;

        // --- Phase 1: Type the prompt instantly, then type the command char by char ---
        const promptLine = document.createElement('div');
        promptLine.className = 'terminal-line';
        container.appendChild(promptLine);

        // Prompt appears instantly
        const promptSpan = document.createElement('span');
        promptSpan.className = 'terminal-prompt';
        promptSpan.innerHTML = 'sourabhsc@<span class="prompt-path">/home/sourabhsc/</span>&gt;<span class="caret">$</span>';
        promptLine.appendChild(promptSpan);

        // Command typed char by char
        const cmdSpan = document.createElement('span');
        cmdSpan.className = 'terminal-command';
        promptLine.appendChild(cmdSpan);

        // Blinking cursor element that moves with typing
        const cursor = document.createElement('span');
        cursor.className = 'typing-cursor';
        cursor.textContent = '\u2588'; // block cursor
        promptLine.appendChild(cursor);

        // Type the command
        for (let i = 0; i < command.length; i++) {
            setTimeout(() => {
                cmdSpan.textContent += command[i];
                scrollToBottom(container);
            }, totalDelay + i * CMD_CHAR_DELAY);
        }
        totalDelay += command.length * CMD_CHAR_DELAY + LINE_PAUSE;

        // Remove cursor from prompt line and start output
        setTimeout(() => {
            cursor.remove();
        }, totalDelay);

        // --- Phase 2: Type each output line char by char ---
        outputLines.forEach((segments, lineIndex) => {
            setTimeout(() => {
                const lineDiv = document.createElement('div');
                lineDiv.className = 'terminal-out-line';
                container.appendChild(lineDiv);

                let segDelay = 0;

                segments.forEach(seg => {
                    if (seg.type === 'link') {
                        // Create link element, type text into it char by char
                        const link = document.createElement('a');
                        link.href = seg.href;
                        link.target = '_blank';
                        link.rel = 'noopener noreferrer';
                        link.className = 'term-link';
                        lineDiv.appendChild(link);

                        for (let c = 0; c < seg.text.length; c++) {
                            setTimeout(() => {
                                link.textContent += seg.text[c];
                                scrollToBottom(container);
                            }, segDelay + c * CHAR_DELAY);
                        }
                        segDelay += seg.text.length * CHAR_DELAY;

                    } else {
                        // Plain text segment (caret, label, text, sep)
                        const span = document.createElement('span');
                        span.className = getSegmentClass(seg.type);
                        lineDiv.appendChild(span);

                        if (seg.type === 'caret') {
                            // Caret appears instantly
                            span.textContent = seg.text;
                        } else {
                            for (let c = 0; c < seg.text.length; c++) {
                                setTimeout(() => {
                                    span.textContent += seg.text[c];
                                    scrollToBottom(container);
                                }, segDelay + c * CHAR_DELAY);
                            }
                            segDelay += seg.text.length * CHAR_DELAY;
                        }
                    }
                });

                // After this line is fully typed, schedule next line
                // (handled by outer setTimeout staggering)
            }, totalDelay);

            // Calculate total chars in this line for delay
            let lineChars = 0;
            segments.forEach(seg => {
                if (seg.type !== 'caret') {
                    lineChars += seg.text.length;
                }
            });
            totalDelay += lineChars * CHAR_DELAY + LINE_PAUSE;
        });

        // --- Phase 3: Show blinking cursor at end ---
        setTimeout(() => {
            const cursorLine = document.createElement('div');
            cursorLine.className = 'terminal-out-line terminal-cursor-line';

            const caretSpan = document.createElement('span');
            caretSpan.className = 'prompt-caret';
            caretSpan.textContent = '>$ ';
            cursorLine.appendChild(caretSpan);

            const blinkCursor = document.createElement('span');
            blinkCursor.className = 'blinking-cursor';
            blinkCursor.textContent = '\u2588';
            cursorLine.appendChild(blinkCursor);

            container.appendChild(cursorLine);
            scrollToBottom(container);
        }, totalDelay);
    }
};

function getSegmentClass(type) {
    switch (type) {
        case 'caret': return 'prompt-caret';
        case 'label': return 'term-label';
        case 'text': return 'term-text';
        case 'sep': return 'term-sep';
        default: return '';
    }
}

function scrollToBottom(el) {
    el.scrollTop = el.scrollHeight;
}
